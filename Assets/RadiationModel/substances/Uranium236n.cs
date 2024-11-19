using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium236n : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium236n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 236.04852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new GammaParticle(0.00045, 2750400.0), new Uranium236() } },
            { 0.13d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    