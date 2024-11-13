
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper72m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper72m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 71.93611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Copper72() } },

        };
    }
}
    
    