using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CarCustomize.CarData;
using CarCustomize.Forms;
using Core;
using Customize;

namespace CarCustomize
{
	public partial class MainForm : BaseForm
	{
		private MemoryManager memoryManager;

		private CarDataManager carDataManager;

		private List<ComboBox> partComboBoxes;

		//private List<Button> colorButtons;

		private Settings settings;

		private bool updated;

		private Form dialogForm;

		private Dictionary<uint, string> cars;

		public MainForm()
		{
			InitializeComponent();

			VinylHelper.Init();

			this.AutoScaleMode = AutoScaleMode.Dpi;

			try
			{
				this.settings = Settings.Read();
			}
			catch
			{
				MessageBox.Show("Error loading settings. Using default", "Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				this.settings = new Settings();
				this.settings.Save();
			}

			this.partComboBoxes = new List<ComboBox>();
			//this.colorButtons = new List<Button>();

			this.InitComboBox(this.Body, Constants.BodyParts);

			this.InitComboBox(this.BumperFront, Constants.BodyParts);
			this.InitComboBox(this.BumperFrontExtra, Constants.BodyParts);
			this.InitComboBox(this.BumperRear, Constants.BodyParts);
			this.InitComboBox(this.BumperRearExtra, Constants.BodyParts);

			this.InitComboBox(this.SkirtLeft, Constants.BodyParts);
			this.InitComboBox(this.SkirtRight, Constants.BodyParts);

			this.InitComboBox(this.FenderLeft, Constants.StockAndWideParts);
			this.InitComboBox(this.FenderRight, Constants.StockAndWideParts);

			this.InitComboBox(this.DoorFrontLeft, Constants.StockAndWideParts);
			this.InitComboBox(this.DoorFrontRight, Constants.StockAndWideParts);
			this.InitComboBox(this.DoorRearLeft, Constants.StockAndWideParts);
			this.InitComboBox(this.DoorRearRight, Constants.StockAndWideParts);

			this.InitComboBox(this.Hood, Constants.HoodParts);

			this.InitComboBox(this.SeatLeft, Constants.SeatParts);
			this.InitComboBox(this.SeatRight, Constants.SeatParts);

			this.InitComboBox(this.Spoiler, Constants.SpoilerParts);

			this.InitComboBox(this.RollCage, Constants.RollCageParts);

			this.InitComboBox(this.Exhaust, Constants.ExhaustParts);

			this.InitComboBox(this.LicensePlate, Constants.LicensePlate);

			this.InitComboBox(this.RoofScoop, Constants.RoofScoopParts);

			//this.InitComboBox(this.Engine, Constants.PerformanceParts);
			//this.InitComboBox(this.Nos, Constants.PerformanceParts);
			//this.InitComboBox(this.Drivetrain, Constants.PerformanceParts);
			//this.InitComboBox(this.Tires, Constants.PerformanceParts);
			//this.InitComboBox(this.Suspension, Constants.PerformanceParts);
			//this.InitComboBox(this.Turbo, Constants.PerformanceParts);
			//this.InitComboBox(this.Brakes, Constants.PerformanceParts);

			this.InitComboBox(this.CarMode, Constants.CarModes, false);

			//this.colorButtons.Add(this.BodyColorBtn);

			var vinylColImg = new DataGridViewImageColumn();
			vinylColImg.ImageLayout = DataGridViewImageCellLayout.Stretch;
			vinylColImg.Name = "imgCol";
			this.vinylsGrid.Columns.Add(vinylColImg);
			this.vinylsGrid.Columns.Add(new DataGridViewTextBoxColumn());

			var decalColImg = new DataGridViewImageColumn();
			decalColImg.ImageLayout = DataGridViewImageCellLayout.Stretch;
			decalColImg.Name = "imgCol";
			this.decalsGrid.Columns.Add(decalColImg);
			this.decalsGrid.Columns.Add(new DataGridViewTextBoxColumn());

			this.InitGrids();

			this.connectBtn_Click();

			this.carLocationUpdateTimer_Tick(null, null);
			this.carLocationUpdateTimer.Enabled = true;

			var perf = this.tabControl.TabPages[2];
			var misc = this.tabControl.TabPages[3];
			var paint = this.tabControl.TabPages[4];
			this.tabControl.TabPages.Remove(perf);
			this.tabControl.TabPages.Remove(misc);
			this.tabControl.TabPages.Remove(paint);
		}

		private void InitGrids()
		{
			this.decalsGrid.RowTemplate.Height = this.settings.ImageSize;
			this.decalsGrid.Columns[0].Width = this.settings.ImageSize;
			this.decalsGrid.Columns[1].Width = this.decalsGrid.Size.Width - this.settings.ImageSize - 25;

			this.vinylsGrid.RowTemplate.Height = this.settings.ImageSize;
			this.vinylsGrid.Columns[0].Width = this.settings.ImageSize;
			this.vinylsGrid.Columns[1].Width = this.vinylsGrid.Size.Width - this.settings.ImageSize - 25;
		}

		private void InitComboBox(ComboBox cb, object dictionary, bool bindEevents = true)
		{
			this.partComboBoxes.Add(cb);

			cb.DisplayMember = "Key";
			cb.ValueMember = "Value";
			cb.DataSource = new BindingSource(dictionary, null);
			if (bindEevents)
			{
				cb.SelectedValueChanged += this.ComboBox_SelectedValueChanged;
			}
		}

		private void InitCars()
		{
			this.cars = new Dictionary<uint, string>();

			var pList = Process.GetProcesses();

			string path = null;
			foreach (var process in pList)
			{
				if (process.ProcessName == this.settings.ProcessName)
				{
					path = process.MainModule.FileName;
					break;
				}
			}

			if (!string.IsNullOrEmpty(path))
			{
				string dir = Path.GetDirectoryName(path) + @"\CARS\";
				var carDirs = Directory.GetDirectories(dir);
				foreach (var carDir in carDirs)
				{
					var name = Path.GetFileName(carDir);
					this.cars.Add(HashString(name), name);
				}
			}
		}

		private static uint HashString(string str)
		{
			uint result = uint.MaxValue;

			foreach (char a in str)
			{
				result = unchecked(a + 33 * result);
			}

			return result;
		}

		private void carLocationUpdateTimer_Tick(object sender, EventArgs e)
		{
			if (this.IsGameActive())
			{
				this.FindCarPointer();

				if (this.ContainsFocus && !this.updated)
				{
					this.UpdateForm();
					this.updated = true;
				}

				if (!this.ContainsFocus && this.dialogForm == null)
				{
					this.updated = false;
				}
			}
			else
			{
				this.Disconnect();
			}
		}

		private void FindCarPointer()
		{
			this.carDataManager.Init();

			var id = this.carDataManager.GetCurrentCarId();
			if (id != 0 && id != int.MaxValue)
			{
				this.tabControl.Enabled = true;
				int num = this.carDataManager.GetCarNum();
				string carName = "";
				if (this.cars.ContainsKey(id))
				{
					carName = this.cars[id];
				}

				this.currentCarName.Text = carName + " (#" + num + ", Blueprint: " + (this.carDataManager.CarConfig + 1) + ")";
			}
			else
			{
				this.tabControl.Enabled = false;
				this.currentCarName.Text = "No car picked";
			}
		}

		private void connectBtn_Click(object sender = null, EventArgs e = null)
		{
			if (this.IsGameActive())
			{
				this.memoryManager = new MemoryManager(this.settings.ProcessName);
				this.carDataManager = new CarDataManager(this.memoryManager, this.carDataManager);
				this.InitCars();

				this.gameStatus.Text = "Connected";
				this.carLocationUpdateTimer.Enabled = true;
				this.connectBtn.Visible = false;
				this.tabControl.Enabled = true;
				this.CopyBtn.Enabled = true;

				if (this.carDataManager.CanPaste)
				{
					this.PasteBtn.Enabled = true;
				}

				this.FindCarPointer();
				this.UpdateForm();
			}
			else
			{
				this.Disconnect();
			}
		}

		private void Disconnect()
		{
			this.gameStatus.Text = "Disconnected";
			this.currentCarName.Text = "";

			this.carLocationUpdateTimer.Enabled = false;
			this.connectBtn.Visible = true;
			this.CopyBtn.Enabled = false;
			this.PasteBtn.Enabled = false;
			this.tabControl.Enabled = false;
		}

		private bool IsGameActive()
		{
			var processes = Process.GetProcessesByName(this.settings.ProcessName);
			return processes.Any();
		}

		private void UpdateForm()
		{
			this.tabControl.Visible = false;

			if (this.partComboBoxes == null)
			{
				return;
			}

			foreach (var comboBox in this.partComboBoxes)
			{
				comboBox.SelectedValue = this.carDataManager.GetPart(comboBox.Name);
			}

			//foreach (var button in this.colorButtons)
			//{
			//	button.BackColor = this.carDataManager.GetColor(button.Name.Substring(0, button.Name.Length - 8));
			//}

			this.CarMode.SelectedValue = this.carDataManager.CarMode;

			this.UpdateVinylGrid(false);
			this.UpdateVinylGrid(true);

			this.tabControl.Visible = true;

			this.UpdateStaticLivery();
		}

		private void UpdateStaticLivery()
		{
			var livery = this.carDataManager.StaticLivery;
			this.StaticLivery.Text = livery == "FFFFFFFF" ? String.Empty : livery;
		}

		private void UpdateVinylGrid(bool isDecal)
		{
			int count = isDecal ? this.carDataManager.DecalCount : this.carDataManager.VinylCount;
			var grid = isDecal ? this.decalsGrid : this.vinylsGrid;

			grid.Rows.Clear();
			for (int i = count; i > 0; i--)
			{
				byte code = (byte)this.carDataManager.GetVinylData(i - 1, isDecal, "Code");
				byte page = (byte)this.carDataManager.GetVinylData(i - 1, isDecal, "Page");

				grid.Rows.Add();
				grid.Rows[count - i].Cells[0].Value = VinylHelper.GetImage(code, page);
				grid.Rows[count - i].Cells[1].Value = "Layer " + i;
			}

			grid.ClearSelection();
			grid.Update();
		}

		private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (this.carDataManager == null || comboBox.SelectedValue == null)
			{
				return;
			}

			this.carDataManager.SetPart(comboBox.Name, (byte)comboBox.SelectedValue);
		}

		private void CarMode_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.carDataManager == null || this.CarMode.SelectedValue == null)
			{
				return;
			}

			this.carDataManager.CarMode = (byte)this.CarMode.SelectedValue;
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CopyBtn_Click(object sender, EventArgs e)
		{
			this.PasteBtn.Enabled = true;
			this.carDataManager.CopyCurrentCar();
		}

		private void PasteBtn_Click(object sender, EventArgs e)
		{
			if (this.PasteVerify())
			{
				this.carDataManager.PasteCopyToCurrentCar();
				this.UpdateForm();
			}
		}

		private void PasteVinylBtn_Click(object sender, EventArgs e)
		{
			if (this.PasteVerify())
			{
				this.carDataManager.PasteCopyVinylToCurrentCar();
				this.UpdateForm();
			}
		}

		private bool PasteVerify()
		{
			var dialogResult = MessageBox.Show("Are you sure you want to paste to the current car?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			return dialogResult == DialogResult.Yes;
		}

		private void AboutBtn_Click(object sender, EventArgs e)
		{
			this.dialogForm = new AboutForm();
			this.dialogForm.ShowDialog();
			this.dialogForm = null;
		}

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			var form = new SettingsForm(this.settings);
			form.ShowDialog();

			this.InitGrids();
		}

		private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var grid = sender as DataGridView;
			bool isDecal = grid.Name == "decalsGrid";

			if (!this.CheckVinylsSelected(isDecal))
			{
				return;
			}

			int layer = this.GetSelectedGridItem(grid, 0);

			this.dialogForm = new VinylEditorForm(this.carDataManager, isDecal, layer);
			if (this.dialogForm.ShowDialog() == DialogResult.OK)
			{
				this.UpdateForm();
			}

			this.Focus();
			this.dialogForm = null;
		}

		private void moveToDecalsBtn_Click(object sender, EventArgs e)
		{
			if (this.CheckDecalsCount() && this.CheckGridSelectedOnlyOne(this.vinylsGrid) && this.CheckVinylsSelected(false))
			{
				this.carDataManager.MoveToDecals(this.GetSelectedGridItem(this.vinylsGrid, 0));
				this.UpdateForm();
			}
		}

		private void moveToVinylsBtn_Click(object sender, EventArgs e)
		{
			if (this.CheckVinylsCount() && this.CheckGridSelectedOnlyOne(this.decalsGrid) && this.CheckVinylsSelected(true))
			{
				this.carDataManager.MoveToVinyls(this.GetSelectedGridItem(this.decalsGrid, 0));
				this.UpdateForm();
			}
		}

		private void deleteVinylBtn_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var grid = btn.Name == "deleteDecalBtn" ? this.decalsGrid : this.vinylsGrid;
			bool isDecal = grid.Name == "decalsGrid";

			if (!this.CheckVinylsSelected(isDecal))
			{
				return;
			}

			DialogResult dialogResult = MessageBox.Show(
				"Are you sure you want to delete selected " + (isDecal ? "decals" : "vinyls") + "?",
				"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				var count = grid.SelectedCells.Count;
				for (int i = 0; i < count; i++)
				{
					var row = this.GetSelectedGridItem(grid, i);
					this.carDataManager.DeleteVinyl(row, isDecal);
				}

				this.UpdateForm();
			}
		}

		private int GetSelectedGridItem(DataGridView grid, int index)
		{
			return grid.RowCount - grid.SelectedCells[index].RowIndex - 1;
		}

		private void addVinylBtn_Click(object sender, EventArgs e)
		{
			bool isDecal = ((Button)sender).Name == "addDecalBtn";

			if (isDecal ? this.CheckDecalsCount() : this.CheckVinylsCount())
			{
				var form = new VinylsChooserForm();
				this.dialogForm = form;
				this.dialogForm.ShowDialog();

				if (form.Picked)
				{
					this.carDataManager.AddVinyl(isDecal, form.Code, form.Page);

					this.UpdateForm();
				}

				this.dialogForm = null;
			}
		}

		private void duplicateVinylBtn_Click(object sender, EventArgs e)
		{
			bool isDecal = ((Button)sender).Name == "duplicateDecalBtn";
			var grid = isDecal ? this.decalsGrid : this.vinylsGrid;

			if ((isDecal ? this.CheckDecalsCount() : this.CheckVinylsCount()) && this.CheckGridSelectedOnlyOne(grid)
																			  && this.CheckVinylsSelected(isDecal))
			{
				var row = this.GetSelectedGridItem(grid, 0);
				this.carDataManager.DuplicateVinyl(row, isDecal);

				this.UpdateForm();
			}
		}

		private bool CheckVinylsCount()
		{
			if (this.carDataManager.VinylCount == 20)
			{
				MessageBox.Show("Vinyl limit reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			return true;
		}

		private bool CheckGridSelectedOnlyOne(DataGridView grid)
		{
			if (grid.SelectedCells.Count > 1)
			{
				MessageBox.Show("You need to select only one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			return true;
		}

		private bool CheckDecalsCount()
		{
			if (this.carDataManager.DecalCount == 20)
			{
				MessageBox.Show("Decal limit reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			return true;
		}

		private bool CheckVinylsSelected(bool isDecal)
		{
			return isDecal ? this.decalsGrid.SelectedCells.Count > 0 : this.vinylsGrid.SelectedCells.Count > 0;
		}

		private void vinylsGrid_MouseDown(object sender, MouseEventArgs e)
		{
			var grid = sender as DataGridView;

			if (this.settings.ShowDoubleClickMessage && grid.RowCount > 0)
			{
				var form = new DontShowAgainForm("Double click item to open its edit form.");
				this.dialogForm = form;

				form.ShowDialog();
				this.settings.ShowDoubleClickMessage = !form.DontShow;
				this.settings.Save();

				this.dialogForm = null;
			}
		}

		private void moveVinylsUp_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			bool isDecal = btn.Name == "moveDecalsUp";
			var grid = isDecal ? this.decalsGrid : this.vinylsGrid;

			var count = grid.SelectedCells.Count;

			bool needToUpdate = false;
			for (int i = 0; i < count; i++)
			{
				var row = this.GetSelectedGridItem(grid, i);
				if (row != grid.RowCount - 1)
				{
					this.carDataManager.SwapVinyls(row, row + 1, isDecal);
					needToUpdate = true;
				}
			}

			if (needToUpdate)
			{
				this.UpdateForm();
			}
		}

		private void moveVinylsDown_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			bool isDecal = btn.Name == "moveDecalsDown";
			var grid = isDecal ? this.decalsGrid : this.vinylsGrid;

			var count = grid.SelectedCells.Count;

			bool needToUpdate = false;
			for (int i = 0; i < count; i++)
			{
				var row = this.GetSelectedGridItem(grid, i);
				if (row != 0)
				{
					this.carDataManager.SwapVinyls(row, row - 1, isDecal);
					needToUpdate = true;
				}
			}

			if (needToUpdate)
			{
				this.UpdateForm();
			}
		}

		private void vinylsGrid_SelectionChanged(object sender, EventArgs e)
		{
			var grid = sender as DataGridView;

			if (grid.CurrentCell != null && grid.Columns[grid.CurrentCell.ColumnIndex].Name == "imgCol")
			{
				grid.CurrentCell.Selected = false;
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;

			this.dialogForm = new PartCustomizationForm(btn.Name.Substring(0, btn.Name.Length - 7), this.carDataManager);
			this.dialogForm.ShowDialog();

			this.dialogForm = null;
		}

		private void lockunlockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.dialogForm = new LockUnlockCarForm(this.carDataManager);

			this.dialogForm.ShowDialog();

			this.dialogForm = null;
		}

		private void StaticLivery_Leave(object sender, EventArgs e)
		{
			if (!(this.StaticLivery.Text.Length == 0 || this.StaticLivery.Text.Length == 8))
			{
				this.UpdateStaticLivery();
				return;
			}

			if (this.StaticLivery.Text.Length == 0 || this.StaticLivery.Text.ToUpper() == "FFFFFFFF")
			{
				this.carDataManager.StaticLivery = "FFFFFFFF";
				this.StaticLivery.Text = String.Empty;
			}
			else
			{
				try
				{
					this.carDataManager.StringToByteArray(this.StaticLivery.Text);
				}
				catch
				{
					this.UpdateStaticLivery();
					return;
				}

				this.carDataManager.StaticLivery = this.StaticLivery.Text;
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog.ShowDialog() == DialogResult.OK)
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to paste file to the current car?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					try
					{
						var bytes = File.ReadAllBytes(this.openFileDialog.FileName);

						if (bytes.Length == Constants.ConfigSize)
						{
							this.carDataManager.CurrentCar = bytes;
						}
					}
					catch
					{
						MessageBox.Show("Error while loading car data", "Error", MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.WriteAllBytes(this.saveFileDialog.FileName, this.carDataManager.CurrentCar);
				}
				catch
				{
					MessageBox.Show("Error while saving car data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void CarMode_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.settings.ShowCarModesMessage)
			{
				var form = new DontShowAgainForm("The game gets car mode from the first blueprint.\n" +
														"However you can still set different car modes \nfor each blueprint");

				this.dialogForm = form;

				this.dialogForm.ShowDialog();

				this.dialogForm = null;

				this.settings.ShowCarModesMessage = !form.DontShow;
				this.settings.Save();
			}
		}

		private void ColorBtnClick(object sender, EventArgs e)
		{
			var btn = sender as Button;

			this.colorDialog.Color = btn.BackColor;
			if (this.colorDialog.ShowDialog() == DialogResult.OK)
			{
				btn.BackColor = this.colorDialog.Color;
			}

			//this.dialogForm = new PartCustomizationForm(btn.Name.Substring(0, btn.Name.Length - 7), this.carDataManager);
			//this.dialogForm.ShowDialog();

			//this.dialogForm = null;
		}
	}
}