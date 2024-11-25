using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70n : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70n";
        public override double halfLife { get; } = 6.6d;
        public override double atomicWeight { get; } = 69.93265d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.932d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc70() }, { 1.0d, new BetaParticle(-1, 3415450.0) }, { 0.029171999999999997d, new GammaParticle(185850.0, 0.00667) }, { 0.083096d, new GammaParticle(874330.0, 0.00142) }, { 0.884d, new GammaParticle(884880.0, 0.0014) }, { 0.169728d, new GammaParticle(1072200.0, 0.00116) }, { 0.07956d, new GammaParticle(1255400.0, 0.00099) }, { 0.057460000000000004d, new GammaParticle(1759600.0, 0.0007) }, { 0.038012000000000004d, new GammaParticle(1875800.0, 0.00066) }, { 1.5e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.00014000000000000001d, new GammaParticle(8616.0, 0.1439) }, { 0.0003d, new GammaParticle(8639.0, 0.14352) }, { 6e-05d, new GammaParticle(9610.0, 0.12902) }, { 6e-05d, new GammaParticle(9610.0, 0.12902) } } },
            { 0.068d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper70() }, { 0.057999999999999996d, new GammaParticle(141300.0, 0.00877) }, { 0.00012348114356d, new GammaParticle(952.0, 1.30236) }, { 0.0011702470352550115d, new GammaParticle(8028.0, 0.15444) }, { 0.0022798500589421614d, new GammaParticle(8048.0, 0.15406) }, { 0.0004799085058028268d, new GammaParticle(8940.0, 0.13868) }, { 0.0004799085058028268d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    