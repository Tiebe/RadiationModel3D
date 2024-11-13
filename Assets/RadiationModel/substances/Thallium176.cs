
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium176";
        public override double halfLife { get; } = 0.0062d;
        public override double atomicWeight { get; } = 176.00062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Mercury175() } },

        };
    }
}
    
    