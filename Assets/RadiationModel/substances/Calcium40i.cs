using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium40i : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium40i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 39.97081d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00016, 7658182.0), new Calcium40() } },

        };
    }
}
    
    