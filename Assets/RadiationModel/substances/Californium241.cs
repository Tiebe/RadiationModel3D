using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium241";
        public override double halfLife { get; } = 226.8d;
        public override double atomicWeight { get; } = 241.06369d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium241() }, { 1.0d, new BetaParticle(1, 2814099.99999) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium237() }, { 1.0d, new AlphaParticle(8677002.09) } } },

        };
    }
}
    