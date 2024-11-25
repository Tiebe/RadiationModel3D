using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium102m";
        public override double halfLife { get; } = 118086016.99692d;
        public override double atomicWeight { get; } = 101.90699d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99767d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium102() }, { 1.0d, new BetaParticle(1, -1034500.0) }, { 0.0021d, new GammaParticle(75600.0, 0.0164) }, { 0.0087d, new GammaParticle(345890.0, 0.00358) }, { 0.021d, new GammaParticle(415250.0, 0.00299) }, { 0.094d, new GammaParticle(418520.0, 0.00296) }, { 0.032d, new GammaParticle(420400.0, 0.00295) }, { 0.95d, new GammaParticle(475060.0, 0.00261) }, { 0.083d, new GammaParticle(628050.0, 0.00197) }, { 0.56d, new GammaParticle(631290.0, 0.00196) }, { 0.016d, new GammaParticle(692400.0, 0.00179) }, { 0.028999999999999998d, new GammaParticle(695600.0, 0.00178) }, { 0.44d, new GammaParticle(697490.0, 0.00178) }, { 0.34d, new GammaParticle(766840.0, 0.00162) }, { 0.34d, new GammaParticle(1046590.0, 0.00118) }, { 0.046d, new GammaParticle(1103160.0, 0.00112) }, { 0.19d, new GammaParticle(1112840.0, 0.00111) }, { 0.0046d, new GammaParticle(1323600.0, 0.00094) }, { 0.0461d, new GammaParticle(2737.0, 0.45299) }, { 0.19899999999999998d, new GammaParticle(19150.0, 0.06474) }, { 0.37799999999999995d, new GammaParticle(19279.0, 0.06431) }, { 0.102d, new GammaParticle(21736.0, 0.05704) }, { 0.11800000000000001d, new GammaParticle(21875.0, 0.05668) }, { 0.016399999999999998d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.00233d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium102() }, { 0.00045d, new GammaParticle(41900.0, 0.02959) }, { 7e-06d, new GammaParticle(98700.0, 0.01256) }, { 0.000211311180444d, new GammaParticle(2892.0, 0.42871) }, { 0.0007856711014959841d, new GammaParticle(20073.0, 0.06177) }, { 0.0014874500217644528d, new GammaParticle(20215.0, 0.06133) }, { 0.00040393713270974493d, new GammaParticle(22806.0, 0.05436) }, { 0.00047099069673956254d, new GammaParticle(22957.0, 0.05401) }, { 6.705356402981765e-05d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    