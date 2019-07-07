using System.Collections.Generic;

namespace CarCustomize
{
	public struct CarPart
	{
		public int Offset;
		public int Code;
	}

	public static class Constants
	{
		public static int ConfigSize = 0x7b4;
		public static int CarSize = 0x1870;
		public static byte NonePart = 0xf0; // just a random part, doesn't matter
		public static byte NoneCode = 0x0C; // magic code that removes parts

		public static int CarLock = 0x8E9;
		public static int StaticLivery = 0x568;
		public static int CarMode = 0x228;

		public static Dictionary<string, byte> CarModes = new Dictionary<string, byte>
		{
			{"Grip", 0},
			{"Drift", 1},
			{"Drag", 2},
			{"Speed", 3},
		};

		public static Dictionary<string, CarPart> CarParts = new Dictionary<string, CarPart>
		{
			{"Body", new CarPart {Offset = 0x44, Code = 0x07}},
			{"BumperFront", new CarPart {Offset = 0x58, Code = 0x6a}},
			{"BumperFrontExtra", new CarPart {Offset = 0x5A, Code = 0x33}},
			{"BumperRear", new CarPart {Offset = 0x5c, Code = 0x47}},
			{"BumperRearExtra", new CarPart {Offset = 0x5e, Code = 0x67}},
			{"SkirtLeft", new CarPart {Offset = 0xE6, Code = 0x50}},
			{"SkirtRight", new CarPart {Offset = 0xE8, Code = 0x54}},
			{"FenderLeft", new CarPart {Offset = 0xC6, Code = 0x2C}},
			{"FenderRight", new CarPart {Offset = 0xC8, Code = 0x56}},
			{"DoorFrontLeft", new CarPart {Offset = 0xB0, Code = 0x1A}},
			{"DoorFrontRight", new CarPart {Offset = 0xB6, Code = 0x69}},
			{"DoorRearLeft", new CarPart {Offset = 0xB2, Code = 0x6E}},
			{"DoorRearRight", new CarPart {Offset = 0xB4, Code = 0x44}},
			{"Hood", new CarPart {Offset = 0xD2, Code = 0x6C}},
			{"SeatLeft", new CarPart {Offset = 0xDE, Code = 0x21}},
			{"SeatRight", new CarPart {Offset = 0xE0, Code = 0x21}},
			{"Spoiler", new CarPart {Offset = 0xEA, Code = 0x5A}},
			{"RollCage", new CarPart {Offset = 0xD6, Code = 0x2B}},
			{"Exhaust", new CarPart {Offset = 0xC4, Code = 0x15}},
			{"LicensePlate", new CarPart {Offset = 0xD4, Code = 0x16}},

			{"Engine", new CarPart {Offset = 0x12C, Code = 0x66}},
			{"Drivetrain", new CarPart {Offset = 0x12A, Code = 0x4B}},
			{"Turbo", new CarPart {Offset = 0x12E, Code = 0x02}},
			{"Suspension", new CarPart {Offset = 0x15A, Code = 0x5E}},
			{"Brakes", new CarPart {Offset = 0x48, Code = 0x31}},
			{"Tires", new CarPart {Offset = 0x15E, Code = 0x4A}},
			{"Nos", new CarPart {Offset = 0x13A, Code = 0x65}},
			{"RoofScoop", new CarPart {Offset = 0xDC, Code = 0x29}},
			{"WheelsFront", new CarPart {Offset = 0xF2, Code = 0x38}},
			{"WheelsRear", new CarPart {Offset = 0xF4, Code = 0x5C}},
		};

		public static int HueMax = 0x59;
		public static int VinylsLocation = 0x238;
		public static int VinylsMirrorLocation = 0x440;
		public static int VinylsCountLocation = 0x444;
		public static int VinylSize = 26;
		public static int DecalsLocation = 0x448;
		public static int DecalsMirrorLocation = 0x560;
		public static int DecalsCountLocation = 0x564;
		public static int DecalSize = 14;
		public static Dictionary<string, byte> Vinyl = new Dictionary<string, byte>
		{
			{"Code", 0},
			{"Page", 1},
			{"OffsetX", 2}, // short
			{"OffsetY", 4}, // short
			{"Rotation", 6},
			{"ScaleY", 7},
			{"ScaleX", 8},
			{"Skew", 9},
			{"Color1_Tone", 10}, // 0 to 0x59
			{"Color1_StrangeByte", 11}, // always 06
			{"Color1_Saturation", 12},
			{"Color1_Brightness", 13},
			{"Color2_Tone", 14},
			{"Color2_StrangeByte", 15},
			{"Color2_Saturation", 16},
			{"Color2_Brightness", 17},
			{"Color3_Tone", 18},
			{"Color3_StrangeByte", 19},
			{"Color3_Saturation", 20},
			{"Color3_Brightness", 21},
			{"Color4_Tone", 22},
			{"Color4_StrangeByte", 23},
			{"Color4_Saturation", 24},
			{"Color4_Brightness", 25},
		};

		public static Dictionary<string, int> Carbon = new Dictionary<string, int>
		{
			{"Hood", 0x223},
			{"BumperFront", 0x220},
			{"BumperRear", 0x221},
			{"Skirts", 0x222}
		};

		public static Dictionary<string, int> Autosculpt = new Dictionary<string, int>
		{
			{"Hood", 0x5F0},
			{"BumperFront", 0x56C},
			{"BumperRear", 0x577},
			{"Skirts", 0x582},
			{"Spoiler", 0x5FB}
		};

		public static Dictionary<string, byte> BodyParts = new Dictionary<string, byte>
		{
			{"None", NonePart},
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 1},
			{"Kit 3", 3},
			{"Kit 4", 4},
			{"Kit 6", 6},
			{"Kit 8", 8},
			{"Kit 9", 9},
			{"Kit 11", 11},
			{"Widebody", 0x11},
		};

		public static Dictionary<string, byte> StockAndWideParts = new Dictionary<string, byte>
		{
			{"Default", 0xff},
			{"Stock", 0},
			{"Widebody", 0x11},
		};

		public static Dictionary<string, byte> HoodParts = new Dictionary<string, byte>
		{
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 0x11},
			{"Kit 2", 0x12},
			{"Kit 3", 0x13},
			{"Kit 4", 0x14},
			{"Kit 5", 0x15},
			{"Kit 6", 0x16},
		};

		public static Dictionary<string, byte> LicensePlate = new Dictionary<string, byte>
		{
			{"None", NonePart},
			{"Default", 0xff}
		};

		public static Dictionary<string, byte> RollCageParts = new Dictionary<string, byte>
		{
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 0x10},
			{"Kit 2", 0x20},
		};

		public static Dictionary<string, byte> SeatParts = new Dictionary<string, byte>
		{
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 0x11},
			{"Kit 2", 0x12},
			{"Kit 3", 0x13},
			{"Kit 4", 0x14},
			{"Kit 5", 0x15},
			{"Kit 6", 0x16},
			{"Kit 7", 0x17},
			{"Kit 8", 0x18},
			{"Kit 9", 0x19},
			{"Kit 10", 0x1A},
		};

		public static Dictionary<string, byte> SpoilerParts = new Dictionary<string, byte>
		{
			{"None", NonePart},
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 0x11},
			{"Kit 2", 0x12},
			{"Kit 3", 0x13},
			{"Kit 4", 0x14},
			{"Kit 5", 0x15},
			{"Kit 6", 0x16},
			{"Kit 7", 0x17},
			{"Kit 8", 0x18},
			{"Kit 9", 0x19},
			{"Kit 10", 0x1A},
			{"Kit 11", 0x1B},
			{"Kit 12", 0x1C},
			{"SPEED", 0x20},
			{"DRAG", 0x30},
		};

		public static Dictionary<string, byte> ExhaustParts = new Dictionary<string, byte>
		{
			{"Default", 0xff},
			{"Stock", 0},
			{"Kit 1", 0x11},
			{"Kit 2", 0x12},
			{"Kit 3", 0x13},
			{"Kit 4", 0x14},
			{"Kit 5", 0x15},
			{"Kit 6", 0x16},
			{"Kit 7", 0x17},
			{"Kit 8", 0x18},
			{"Kit 9", 0x19},
			{"Kit 10", 0x1A},
			{"Kit 11", 0x1B},
			{"Kit 12", 0x1C},
			{"Kit 13", 0x1D},
			{"Kit 14", 0x1E},
			{"Kit 15", 0x1F},
		};

		public static Dictionary<uint, string> CarList = new Dictionary<uint, string>
		{
			{22084480, "Nissan 240SX"},
			{706257, "Nissan 350Z"},
			{1008903605, "Porsche 997GT2"},
			{1008903606, "Porsche 997GT3"},
			{3479369243, "Porsche 997GT3RS"},
			{30573264, "Porsche 997TT"},
			{41999877, "BMW M3 E46"},
			{1816135925, "BMW M3 E92"},
			{1385997280, "BMW M Z4"},
			{1410528946, "Chevrolet CAMARO SS"},
			{3597782336, "Chevrolet CAMARO"},
			{3787143290, "Porsche Carrera GT"},
			{3612426091, "Porsche Cayman S"},
			{39325, "Koenigsegg  CCX"},
			{1008844988, "Dodge Challenger 1971"},
			{290872130, "Dodge Challenger"},
			{990337002, "Dodge Charger 1969"},
			{2924392039, "Chevrolet Chevelle"},
			{3921809687, "Honda Civic"},
			{3921810057, "Honda Civic SI"},
			{3232683226, "Chevrolet Cobalt SS"},
			{4152103915, "Toyota Corolla"},
			{3883502315, "Chevrolet Corvette"},
			{2886203608, "Chevrolet Corvette 1967"},
			{755477579, "Chevrolet Corvette Z06"},
			{3924180824, "Ford Escort Cosworth"},
			{1316159, "Cadillac CTSV"},
			{1316732, "Plymouth HEMI Cuda"},
			{40350, "Aston Martin DB9"},
			{1332432, "Aston Martin DBR9"},
			{44072489, "Lancia Delta Integrale"},
			{1963121284, "Mitsubishi Eclipse"},
			{45506673, "Lotus Elise"},
			{3713975206, "Ford Focus ST"},
			{1544720613, "Ford GT"},
			{43118, "Infiniti G35"},
			{3616032760, "Lamborghini Gallardo"},
			{44227, "Wolksvagen Golf GTI"},
			{44233, "Pontiac GTO"},
			{48171572, "Pontiac GTO65"},
			{419333856, "Nissan GTR PROTO"},
			{3918447144, "Subaru Impreza WRX STI"},
			{398674152, "Honda Integra"},
			{3446860733, "Honda Integra TYPE-R"},
			{50476947, "Lexus IS350"},
			{164818935, "Mitsubishi Evolution 9"},
			{164818966, "Mitsubishi Evolution X"},
			{3132940680, "Seat Leon Cupra"},
			{4207840464, "Mazda Speed 3"},
			{1383760312, "McLaren F1"},
			{133082177, "Lamborghini Murciélago 640"},
			{890656001, "Ford Mustang 2003"},
			{890656793, "Ford Mustang GT"},
			{630607726, "Shelby Mustang"},
			{630607727, "Shelby Mustang 1967"},
			{51832, "Acura NSX"},
			{1987012766, "Audi R8"},
			{55094, "Wolksvagen Golf R32"},
			{3977320447, "Plymouth ROADRUNNER"},
			{56152, "Audi RS4"},
			{56188, "Acura RSX"},
			{56320, "Mazda RX7"},
			{56321, "Mazda RX8"},
			{1701, "Audi S3"},
			{1702, "Audi S4"},
			{61146804, "Honda S2000"},
			{2046169223, "Nissan SILVIA"},
			{3192403806, "Nissan SKYLINE GTR R34"},
			{2544223800, "Nissan GTR"},
			{1881449, "Mercedes SL65"},
			{1794097140, "Pontiac Solstice GXP"},
			{62440586, "Toyota SUPRA"},
			{58389, "Audi TT"},
			{2159294754, "Bugatti Veyron"},
			{65566693, "Dodge Viper"},
			{70523771, "Pagani Zonda"}
		};
	}
}