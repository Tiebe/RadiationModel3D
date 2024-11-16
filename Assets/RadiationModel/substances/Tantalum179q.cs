using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum179q : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179q";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 178.94735d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1317199.99999, 0.00094)), new Tantalum179() } },

        };
    }
}
    
    