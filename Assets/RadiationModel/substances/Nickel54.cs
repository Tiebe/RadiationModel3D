using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel54 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel54";
        public override double halfLife { get; } = 0.1142d;
        public override double atomicWeight { get; } = 53.95783d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron54() }, { 1.0d, new BetaParticle(1, 8488300.0) }, { 0.19699999999999998d, new GammaParticle(936700.0, 0.00132) }, { 0.001576d, new GammaParticle(2424600.0, 0.00051) }, { 0.0037233d, new GammaParticle(3376100.0, 0.00037) }, { 0.0020882d, new GammaParticle(3889600.0, 0.00032) }, { 0.0011819999999999999d, new GammaParticle(4293400.0, 0.00029) }, { 0.0014578d, new GammaParticle(4323000.0, 0.00029) }, { 0.0011819999999999999d, new GammaParticle(4543800.0, 0.00027) }, { 0.0004531d, new GammaParticle(4822800.0, 0.00026) }, { 0.00024428d, new GammaParticle(5202400.0, 0.00024) }, { 2.0082d, new GammaParticle(511000.0, 0.00243) }, { 1.1775326256e-05d, new GammaParticle(800.0, 1.5498) }, { 0.00012383670335267276d, new GammaParticle(6915.0, 0.1793) }, { 0.0002420576687894307d, new GammaParticle(6930.0, 0.17891) }, { 5.020070785789659e-05d, new GammaParticle(7677.0, 0.1615) }, { 5.020070785789659e-05d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    