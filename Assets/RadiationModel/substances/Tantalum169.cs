
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum169 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum169";
        public override double halfLife { get; } = 294.0d;
        public override double atomicWeight { get; } = 168.94601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium169() } },

        };
    }
}
    
    