using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium242";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 242.062d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium242() }, { 1.0d, new BetaParticle(1, 1141000.0) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium238() }, { 1.0d, new AlphaParticle(7927002.09) } } },

        };
    }
}
    