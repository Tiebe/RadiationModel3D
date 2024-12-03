using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium150m";
        public override double halfLife { get; } = 46080.0d;
        public override double atomicWeight { get; } = 149.91975d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium150()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium150()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00021999999999999998d, new GammaParticle(209400.0, 0.00592)), new(3.2e-05d, new GammaParticle(305400.0, 0.00406)), new(0.04d, new GammaParticle(333900.0, 0.00371)), new(0.027999999999999997d, new GammaParticle(406500.0, 0.00305)), new(7.900000000000001e-05d, new GammaParticle(425300.0, 0.00292)), new(0.00032d, new GammaParticle(620300.0, 0.002)), new(0.0013d, new GammaParticle(712200.0, 0.00174)), new(0.002d, new GammaParticle(831800.0, 0.00149)), new(8.999999999999999e-05d, new GammaParticle(860100.0, 0.00144)), new(0.00043999999999999996d, new GammaParticle(917700.0, 0.00135)), new(0.0021d, new GammaParticle(921700.0, 0.00135)), new(8e-05d, new GammaParticle(1046200.0, 0.00119)), new(0.0026d, new GammaParticle(1165700.0, 0.00106)), new(0.00017999999999999998d, new GammaParticle(1193700.0, 0.00104)), new(0.002d, new GammaParticle(1223000.0, 0.00101)), new(0.00015d, new GammaParticle(1452300.0, 0.00085)), new(0.00057d, new GammaParticle(1629400.0, 0.00076)), new(0.00115d, new GammaParticle(1963000.0, 0.00063)), new(0.013560000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.0146934776150912d, new GammaParticle(6354.0, 0.19513)), new(0.02429096438801782d, new GammaParticle(39522.0, 0.03137)), new(0.04396554640365216d, new GammaParticle(40117.0, 0.03091)), new(0.013743540686430848d, new GammaParticle(45523.0, 0.02724)), new(0.017289374183530007d, new GammaParticle(45998.0, 0.02695)), new(0.003545833497099159d, new GammaParticle(46575.0, 0.02662)) } },
            { 4.999999999999999e-10d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium150()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    