using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium101";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 100.9543d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium101() }, { 1.0d, new BetaParticle(-1, 6379000.0) }, { 0.01575d, new GammaParticle(92200.0, 0.01345) }, { 0.0351d, new GammaParticle(92800.0, 0.01336) }, { 0.126d, new GammaParticle(111600.0, 0.01111) }, { 0.013500000000000002d, new GammaParticle(124700.0, 0.00994) }, { 0.027000000000000003d, new GammaParticle(134500.0, 0.00922) }, { 0.013500000000000002d, new GammaParticle(160400.0, 0.00773) }, { 0.0171d, new GammaParticle(160900.0, 0.00771) }, { 0.013500000000000002d, new GammaParticle(216500.0, 0.00573) }, { 0.0342d, new GammaParticle(232700.0, 0.00533) }, { 0.13949999999999999d, new GammaParticle(251600.0, 0.00493) }, { 0.45d, new GammaParticle(271200.0, 0.00457) }, { 0.0603d, new GammaParticle(363100.0, 0.00341) }, { 0.11699999999999999d, new GammaParticle(1091800.0, 0.00114) }, { 0.063d, new GammaParticle(1362900.0, 0.00091) }, { 0.0008720483482200001d, new GammaParticle(1890.0, 0.656) }, { 0.005490664645785169d, new GammaParticle(14098.0, 0.08794) }, { 0.010548827369423957d, new GammaParticle(14165.0, 0.08753) }, { 0.0026046431723813056d, new GammaParticle(15898.0, 0.07799) }, { 0.002943246784790875d, new GammaParticle(15955.0, 0.07771) }, { 0.00033860361240956976d, new GammaParticle(16085.0, 0.07708) } } },
            { 0.28d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium101() }, { 1.0d, new BetaParticle(-1, 6379000.0) }, { 0.01575d, new GammaParticle(92200.0, 0.01345) }, { 0.0351d, new GammaParticle(92800.0, 0.01336) }, { 0.126d, new GammaParticle(111600.0, 0.01111) }, { 0.013500000000000002d, new GammaParticle(124700.0, 0.00994) }, { 0.027000000000000003d, new GammaParticle(134500.0, 0.00922) }, { 0.013500000000000002d, new GammaParticle(160400.0, 0.00773) }, { 0.0171d, new GammaParticle(160900.0, 0.00771) }, { 0.013500000000000002d, new GammaParticle(216500.0, 0.00573) }, { 0.0342d, new GammaParticle(232700.0, 0.00533) }, { 0.13949999999999999d, new GammaParticle(251600.0, 0.00493) }, { 0.45d, new GammaParticle(271200.0, 0.00457) }, { 0.0603d, new GammaParticle(363100.0, 0.00341) }, { 0.11699999999999999d, new GammaParticle(1091800.0, 0.00114) }, { 0.063d, new GammaParticle(1362900.0, 0.00091) }, { 0.0008720483482200001d, new GammaParticle(1890.0, 0.656) }, { 0.005490664645785169d, new GammaParticle(14098.0, 0.08794) }, { 0.010548827369423957d, new GammaParticle(14165.0, 0.08753) }, { 0.0026046431723813056d, new GammaParticle(15898.0, 0.07799) }, { 0.002943246784790875d, new GammaParticle(15955.0, 0.07771) }, { 0.00033860361240956976d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    