using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus32i : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus32i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 31.97935d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00024, 5072440.0), new Phosphorus32() } },

        };
    }
}
    
    