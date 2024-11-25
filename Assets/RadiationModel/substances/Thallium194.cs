using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium194";
        public override double halfLife { get; } = 1980.0d;
        public override double atomicWeight { get; } = 193.97108d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold194() }, { 1.0d, new BetaParticle(1, 2637450.0) }, { 0.015d, new GammaParticle(395390.0, 0.00314) }, { 0.006999999999999999d, new GammaParticle(404190.0, 0.00307) }, { 0.75d, new GammaParticle(427910.0, 0.0029) }, { 0.091d, new GammaParticle(636340.0, 0.00195) }, { 0.10800000000000001d, new GammaParticle(645180.0, 0.00192) }, { 0.013999999999999999d, new GammaParticle(978700.0, 0.00127) }, { 0.048d, new GammaParticle(1040500.0, 0.00119) }, { 0.048d, new GammaParticle(1073000.0, 0.00116) }, { 0.02d, new GammaParticle(1529900.0, 0.00081) }, { 0.042d, new GammaParticle(1551600.0, 0.0008) }, { 0.0064d, new GammaParticle(1623500.0, 0.00076) }, { 0.63d, new GammaParticle(511000.0, 0.00243) }, { 0.20376000685295d, new GammaParticle(11777.0, 0.10528) }, { 0.16129407555395925d, new GammaParticle(68894.0, 0.018) }, { 0.2734261324867931d, new GammaParticle(70820.0, 0.01751) }, { 0.09279410473259679d, new GammaParticle(80316.0, 0.01544) }, { 0.11998277741924765d, new GammaParticle(81285.0, 0.01525) }, { 0.02718867268665086d, new GammaParticle(82477.0, 0.01503) } } },
            { 9.999999999999999e-10d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold190() }, { 1.0d, new AlphaParticle(4494002.09) } } },

        };
    }
}
    