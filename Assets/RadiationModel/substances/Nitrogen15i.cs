
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen15i : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen15i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.01258d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 5.2300000000000004e-05d, new List<RadioactiveSubstance> { new GammaParticle(), new Nitrogen15() } },

        };
    }
}
    
    