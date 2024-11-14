using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium259m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium259m";
        public override double halfLife { get; } = 0.226d;
        public override double atomicWeight { get; } = 259.11445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new List<RadioactiveSubstance> { new AlphaParticle(10875047.4), new Rutherfordium255() } },
            { 0.03d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    