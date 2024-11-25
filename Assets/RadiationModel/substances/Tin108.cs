using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin108 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin108";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 107.91189d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium108() }, { 1.0d, new BetaParticle(1, 3591200.0) }, { 0.0043081000000000005d, new GammaParticle(36700.0, 0.03378) }, { 0.138245d, new GammaParticle(104310.0, 0.01189) }, { 0.19933d, new GammaParticle(168240.0, 0.00737) }, { 0.062370999999999996d, new GammaParticle(236190.0, 0.00525) }, { 0.455244d, new GammaParticle(272690.0, 0.00455) }, { 0.0012859999999999998d, new GammaParticle(363000.0, 0.00342) }, { 0.643d, new GammaParticle(396340.0, 0.00313) }, { 0.010287999999999999d, new GammaParticle(492650.0, 0.00252) }, { 0.010931d, new GammaParticle(500400.0, 0.00248) }, { 0.0012859999999999998d, new GammaParticle(565000.0, 0.00219) }, { 0.22569299999999998d, new GammaParticle(669160.0, 0.00185) }, { 0.0012859999999999998d, new GammaParticle(829300.0, 0.0015) }, { 0.0012859999999999998d, new GammaParticle(847600.0, 0.00146) }, { 0.0012859999999999998d, new GammaParticle(858700.0, 0.00144) }, { 0.032793d, new GammaParticle(889160.0, 0.00139) }, { 0.0012859999999999998d, new GammaParticle(903500.0, 0.00137) }, { 0.009002d, new GammaParticle(1161830.0, 0.00107) }, { 0.0012859999999999998d, new GammaParticle(1231000.0, 0.00101) }, { 0.0012859999999999998d, new GammaParticle(1654400.0, 0.00075) }, { 0.0012859999999999998d, new GammaParticle(1684800.0, 0.00074) }, { 0.0012859999999999998d, new GammaParticle(1957200.0, 0.00063) }, { 0.0126d, new GammaParticle(511000.0, 0.00243) }, { 0.0765701845713504d, new GammaParticle(3571.0, 0.3472) }, { 0.24813651293722214d, new GammaParticle(24001.0, 0.05166) }, { 0.46554692858765884d, new GammaParticle(24209.0, 0.05121) }, { 0.13062206181858746d, new GammaParticle(27367.0, 0.0453) }, { 0.15544025356411906d, new GammaParticle(27581.0, 0.04495) }, { 0.024818191745531615d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    