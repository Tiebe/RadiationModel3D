using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium204";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 204.00651d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon200() }, { 1.0d, new AlphaParticle(8658002.09) } } },

        };
    }
}
    