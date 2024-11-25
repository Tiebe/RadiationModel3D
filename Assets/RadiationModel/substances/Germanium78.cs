using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium78";
        public override double halfLife { get; } = 5280.0d;
        public override double atomicWeight { get; } = 77.92285d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic78() }, { 1.0d, new BetaParticle(-1, 477500.0) }, { 0.96d, new GammaParticle(277300.0, 0.00447) }, { 0.04032d, new GammaParticle(293900.0, 0.00422) } } },

        };
    }
}
    