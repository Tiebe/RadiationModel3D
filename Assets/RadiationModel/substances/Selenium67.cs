using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium67";
        public override double halfLife { get; } = 0.133d;
        public override double atomicWeight { get; } = 66.94999d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium67() }, { 1.0d, new BetaParticle(1, 8047000.0) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium66() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    