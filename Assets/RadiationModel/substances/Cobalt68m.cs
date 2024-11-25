using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt68m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt68m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 67.94472d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel68() }, { 1.0d, new BetaParticle(-1, 5986900.0) }, { 0.08787d, new GammaParticle(113500.0, 0.01092) }, { 0.435d, new GammaParticle(271900.0, 0.00456) }, { 0.38454d, new GammaParticle(323600.0, 0.00383) }, { 0.014790000000000001d, new GammaParticle(377400.0, 0.00329) }, { 0.322335d, new GammaParticle(595200.0, 0.00208) }, { 0.20401499999999997d, new GammaParticle(708900.0, 0.00175) }, { 1.0005d, new GammaParticle(815000.0, 0.00152) }, { 1.0005d, new GammaParticle(2033200.0, 0.00061) }, { 4.390312146696e-05d, new GammaParticle(874.0, 1.41858) }, { 0.0004399322229594002d, new GammaParticle(7461.0, 0.16618) }, { 0.0008585718636990636d, new GammaParticle(7478.0, 0.1658) }, { 0.00017893386314153632d, new GammaParticle(8296.0, 0.14945) }, { 0.00017893386314153632d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    