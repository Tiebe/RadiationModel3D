using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium230";
        public override double halfLife { get; } = 1503360.0d;
        public override double atomicWeight { get; } = 230.03454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.922d, new List<RadioactiveSubstance> { new BetaParticle(1, 1311500.0), new Thorium230() } },
            { 0.078d, new List<RadioactiveSubstance> { new BetaParticle(-1, 559000.0), new Uranium230() } },
            { 3.2e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6460047.4), new Actinium226() } },

        };
    }
}
    
    