
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium99m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 98.91695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Zirconium99() } },

        };
    }
}
    
    