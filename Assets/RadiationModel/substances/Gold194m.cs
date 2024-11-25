using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold194m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194m";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 193.96553d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold194() }, { 0.00013299999999999998d, new GammaParticle(26900.0, 0.04609) }, { 0.023d, new GammaParticle(35220.0, 0.0352) }, { 0.055999999999999994d, new GammaParticle(45290.0, 0.02738) }, { 0.7451675d, new GammaParticle(11419.0, 0.10858) } } },

        };
    }
}
    