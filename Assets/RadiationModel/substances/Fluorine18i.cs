using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine18i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 18.00206d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00119, 1041599.9999999999), new Fluorine18() } },

        };
    }
}
    
    