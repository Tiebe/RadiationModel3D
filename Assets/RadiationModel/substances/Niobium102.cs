using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium102";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 101.91809d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum102() }, { 1.0d, new BetaParticle(-1, 3631350.0) }, { 0.0147d, new GammaParticle(151000.0, 0.00821) }, { 0.7938d, new GammaParticle(296000.0, 0.00419) }, { 0.006860000000000001d, new GammaParticle(367300.0, 0.00338) }, { 0.034300000000000004d, new GammaParticle(397400.0, 0.00312) }, { 0.01862d, new GammaParticle(401000.0, 0.00309) }, { 0.00196d, new GammaParticle(401700.0, 0.00309) }, { 0.196d, new GammaParticle(447100.0, 0.00277) }, { 0.0196d, new GammaParticle(501900.0, 0.00247) }, { 0.00196d, new GammaParticle(506100.0, 0.00245) }, { 0.0294d, new GammaParticle(550100.0, 0.00225) }, { 0.3038d, new GammaParticle(551600.0, 0.00225) }, { 0.00392d, new GammaParticle(552000.0, 0.00225) }, { 0.01176d, new GammaParticle(584100.0, 0.00212) }, { 0.00882d, new GammaParticle(624100.0, 0.00199) }, { 0.03528d, new GammaParticle(654800.0, 0.00189) }, { 0.0147d, new GammaParticle(733100.0, 0.00169) }, { 0.1862d, new GammaParticle(847400.0, 0.00146) }, { 0.01764d, new GammaParticle(864300.0, 0.00143) }, { 0.00196d, new GammaParticle(873500.0, 0.00142) }, { 0.1764d, new GammaParticle(949000.0, 0.00131) }, { 0.00784d, new GammaParticle(953200.0, 0.0013) }, { 0.02352d, new GammaParticle(1004000.0, 0.00123) }, { 0.02254d, new GammaParticle(1021900.0, 0.00121) }, { 0.01764d, new GammaParticle(1082600.0, 0.00115) }, { 0.0147d, new GammaParticle(1102400.0, 0.00112) }, { 0.006860000000000001d, new GammaParticle(1126100.0, 0.0011) }, { 0.0147d, new GammaParticle(1231000.0, 0.00101) }, { 0.13720000000000002d, new GammaParticle(1235300.0, 0.001) }, { 0.00588d, new GammaParticle(1249100.0, 0.00099) }, { 0.00882d, new GammaParticle(1320200.0, 0.00094) }, { 0.00882d, new GammaParticle(1451100.0, 0.00085) }, { 0.41159999999999997d, new GammaParticle(1632700.0, 0.00076) }, { 0.020579999999999998d, new GammaParticle(1737200.0, 0.00071) }, { 0.06174d, new GammaParticle(2184300.0, 0.00057) }, { 0.0009194383893926448d, new GammaParticle(2440.0, 0.50813) }, { 0.004571553491992733d, new GammaParticle(17374.0, 0.07136) }, { 0.008712699622627659d, new GammaParticle(17479.0, 0.07093) }, { 0.0022861808219788644d, new GammaParticle(19681.0, 0.063) }, { 0.002638252668563609d, new GammaParticle(19794.0, 0.06264) }, { 0.00035207184658474515d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    