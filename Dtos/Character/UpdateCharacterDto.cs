using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superapi.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Hero";
        public int HitPoints { get; set; } = 10;
        public int Intelligence { get; set; } = 100;
        public int Strength { get; set; } = 100;
        public int MyProperty { get; set; } = 100;
        public TestEnum KlasaPostaci {get; set;} = TestEnum.Knight;
    }
}