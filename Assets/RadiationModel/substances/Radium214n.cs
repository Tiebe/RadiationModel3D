using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium214n : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 214.0021d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9991d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium214() } } },
            { 0.9991d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon214() }, { 1.0d, new BetaParticle(1, 3139000.0) } } },
            { 0.0009d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon210() }, { 1.0d, new AlphaParticle(10160002.09) } } },

        };
    }
}
    