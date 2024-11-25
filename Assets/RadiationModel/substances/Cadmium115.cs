using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium115";
        public override double halfLife { get; } = 192456.0d;
        public override double atomicWeight { get; } = 114.90544d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium115() }, { 1.0d, new BetaParticle(-1, 725928.5) }, { 0.00421d, new GammaParticle(35570.0, 0.03486) }, { 0.0074d, new GammaParticle(231443.0, 0.00536) }, { 9.000000000000001e-07d, new GammaParticle(252000.0, 0.00492) }, { 0.0194d, new GammaParticle(260896.0, 0.00475) }, { 0.00092d, new GammaParticle(266985.0, 0.00464) }, { 3.3e-05d, new GammaParticle(328380.0, 0.00378) }, { 0.46020000000000005d, new GammaParticle(336241.0, 0.00369) }, { 8e-08d, new GammaParticle(344200.0, 0.0036) }, { 6.1000000000000005e-05d, new GammaParticle(363950.0, 0.00341) }, { 0.0803d, new GammaParticle(492351.0, 0.00252) }, { 0.27449999999999997d, new GammaParticle(527901.0, 0.00235) }, { 1.7e-05d, new GammaParticle(595375.0, 0.00208) }, { 6.1e-06d, new GammaParticle(690230.0, 0.0018) }, { 8.000000000000001e-07d, new GammaParticle(705180.0, 0.00176) }, { 2.2000000000000003e-05d, new GammaParticle(856245.0, 0.00145) }, { 7e-07d, new GammaParticle(941420.0, 0.00132) }, { 2.8e-06d, new GammaParticle(951190.0, 0.0013) }, { 2e-06d, new GammaParticle(1078200.0, 0.00115) }, { 0.034698683444189374d, new GammaParticle(3571.0, 0.3472) }, { 0.1063735620542867d, new GammaParticle(24001.0, 0.05166) }, { 0.19957516332886813d, new GammaParticle(24209.0, 0.05121) }, { 0.05599632973819422d, new GammaParticle(27367.0, 0.0453) }, { 0.06663563238845112d, new GammaParticle(27581.0, 0.04495) }, { 0.0106393026502569d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    