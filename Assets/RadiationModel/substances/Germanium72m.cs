
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium72m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium72m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 71.92282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Germanium72() } },

        };
    }
}
    
    