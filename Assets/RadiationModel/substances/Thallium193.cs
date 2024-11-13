
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium193 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium193";
        public override double halfLife { get; } = 1296.0d;
        public override double atomicWeight { get; } = 192.9705d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury193() } },

        };
    }
}
    
    