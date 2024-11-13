
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium230";
        public override double halfLife { get; } = 5580.0d;
        public override double atomicWeight { get; } = 230.03705d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Actinium230() } },

        };
    }
}
    
    