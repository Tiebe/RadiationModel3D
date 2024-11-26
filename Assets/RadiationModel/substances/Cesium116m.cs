using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium116m";
        public override double halfLife { get; } = 3.85d;
        public override double atomicWeight { get; } = 115.9335d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine116() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.01316d, new GammaParticle(269600.0, 0.0046) }, { 0.037599999999999995d, new GammaParticle(322200.0, 0.00385) }, { 0.01222d, new GammaParticle(345900.0, 0.00358) }, { 0.009399999999999999d, new GammaParticle(360200.0, 0.00344) }, { 0.94d, new GammaParticle(393500.0, 0.00315) }, { 0.0282d, new GammaParticle(458300.0, 0.00271) }, { 0.011279999999999998d, new GammaParticle(465400.0, 0.00266) }, { 0.0235d, new GammaParticle(517300.0, 0.0024) }, { 0.752d, new GammaParticle(524300.0, 0.00236) }, { 0.018799999999999997d, new GammaParticle(528500.0, 0.00235) }, { 0.05734d, new GammaParticle(541200.0, 0.00229) }, { 0.00846d, new GammaParticle(552900.0, 0.00224) }, { 0.0141d, new GammaParticle(556600.0, 0.00223) }, { 0.06862d, new GammaParticle(560200.0, 0.00221) }, { 0.01504d, new GammaParticle(584200.0, 0.00212) }, { 0.0564d, new GammaParticle(611300.0, 0.00203) }, { 0.30079999999999996d, new GammaParticle(615100.0, 0.00202) }, { 0.10339999999999999d, new GammaParticle(622300.0, 0.00199) }, { 0.0705d, new GammaParticle(639300.0, 0.00194) }, { 0.00658d, new GammaParticle(656300.0, 0.00189) }, { 0.009399999999999999d, new GammaParticle(659500.0, 0.00188) }, { 0.03572d, new GammaParticle(677400.0, 0.00183) }, { 0.009399999999999999d, new GammaParticle(684100.0, 0.00181) }, { 0.009399999999999999d, new GammaParticle(706600.0, 0.00175) }, { 0.00376d, new GammaParticle(823000.0, 0.00151) }, { 0.01504d, new GammaParticle(874900.0, 0.00142) }, { 0.0329d, new GammaParticle(903700.0, 0.00137) }, { 0.0235d, new GammaParticle(905900.0, 0.00137) }, { 0.03572d, new GammaParticle(911200.0, 0.00136) }, { 0.00846d, new GammaParticle(921400.0, 0.00135) }, { 0.00376d, new GammaParticle(927900.0, 0.00134) }, { 0.01504d, new GammaParticle(965600.0, 0.00128) }, { 0.005639999999999999d, new GammaParticle(969400.0, 0.00128) }, { 0.005639999999999999d, new GammaParticle(1008500.0, 0.00123) }, { 0.0329d, new GammaParticle(1015800.0, 0.00122) }, { 0.018799999999999997d, new GammaParticle(1033900.0, 0.0012) }, { 0.009399999999999999d, new GammaParticle(1035900.0, 0.0012) }, { 0.01034d, new GammaParticle(1044900.0, 0.00119) }, { 0.0705d, new GammaParticle(1061500.0, 0.00117) }, { 0.01692d, new GammaParticle(1072700.0, 0.00116) }, { 0.0705d, new GammaParticle(1080700.0, 0.00115) }, { 0.01504d, new GammaParticle(1164300.0, 0.00106) }, { 0.0282d, new GammaParticle(1168000.0, 0.00106) }, { 0.018799999999999997d, new GammaParticle(1247000.0, 0.00099) }, { 0.018799999999999997d, new GammaParticle(1321500.0, 0.00094) }, { 0.00846d, new GammaParticle(1441000.0, 0.00086) }, { 0.01504d, new GammaParticle(1446000.0, 0.00086) }, { 1.994d, new GammaParticle(511000.0, 0.00243) }, { 0.0008383190848240001d, new GammaParticle(4540.0, 0.27309) }, { 0.0023212386172044926d, new GammaParticle(29458.0, 0.04209) }, { 0.00430018269211651d, new GammaParticle(29778.0, 0.04164) }, { 0.0012466057756302569d, new GammaParticle(33726.0, 0.03676) }, { 0.0015408047386789975d, new GammaParticle(34030.0, 0.03643) }, { 0.00029419896304874065d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.0051d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine115() }, { 1.0d, new ProtonParticle() } } },
            { 8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium112() }, { 1.0d, new AlphaParticle(14225002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    