
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium82m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium82m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 81.94333d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Gallium82() } },

        };
    }
}
    
    