using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium258";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 258.10898d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.77d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium254() }, { 1.0d, new AlphaParticle(10457002.09) } } },
            { 0.23d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium258() }, { 1.0d, new BetaParticle(1, 3365000.0) } } },

        };
    }
}
    