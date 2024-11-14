using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium263";
        public override double halfLife { get; } = 0.94d;
        public override double atomicWeight { get; } = 263.1183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(10425047.4), new Rutherfordium259() } },
            { 0.13d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    