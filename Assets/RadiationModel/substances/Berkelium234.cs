using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium234";
        public override double halfLife { get; } = 140.0d;
        public override double atomicWeight { get; } = 234.05733d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium230() }, { 1.0d, new AlphaParticle(9127002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium234() } } },

        };
    }
}
    