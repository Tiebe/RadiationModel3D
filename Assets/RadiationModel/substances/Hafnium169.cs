
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium169";
        public override double halfLife { get; } = 194.4d;
        public override double atomicWeight { get; } = 168.94126d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium169() } },

        };
    }
}
    
    