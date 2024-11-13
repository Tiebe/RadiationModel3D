
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177";
        public override double halfLife { get; } = 202896.0d;
        public override double atomicWeight { get; } = 176.94448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium177() } },

        };
    }
}
    
    