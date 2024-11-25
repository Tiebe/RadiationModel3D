using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium115";
        public override double halfLife { get; } = 0.318d;
        public override double atomicWeight { get; } = 114.92903d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium115() }, { 1.0d, new BetaParticle(-1, 4062000.0) }, { 0.1079d, new GammaParticle(80100.0, 0.01548) }, { 0.08549d, new GammaParticle(196500.0, 0.00631) }, { 0.25398d, new GammaParticle(207000.0, 0.00599) }, { 0.01909d, new GammaParticle(231400.0, 0.00536) }, { 0.018260000000000002d, new GammaParticle(239200.0, 0.00518) }, { 0.02407d, new GammaParticle(245100.0, 0.00506) }, { 0.83d, new GammaParticle(292500.0, 0.00424) }, { 0.02407d, new GammaParticle(358400.0, 0.00346) }, { 0.08217d, new GammaParticle(372500.0, 0.00333) }, { 0.03154d, new GammaParticle(435500.0, 0.00285) }, { 0.02656d, new GammaParticle(438300.0, 0.00283) }, { 0.03818d, new GammaParticle(441900.0, 0.00281) }, { 0.01494d, new GammaParticle(618100.0, 0.00201) }, { 0.00332d, new GammaParticle(630000.0, 0.00197) }, { 0.03154d, new GammaParticle(638300.0, 0.00194) }, { 0.05727d, new GammaParticle(710400.0, 0.00175) }, { 0.03071d, new GammaParticle(718300.0, 0.00173) }, { 0.01992d, new GammaParticle(966300.0, 0.00128) }, { 0.00747d, new GammaParticle(974900.0, 0.00127) }, { 0.0166d, new GammaParticle(1025800.0, 0.00121) }, { 0.023239999999999997d, new GammaParticle(1040100.0, 0.00119) }, { 0.01079d, new GammaParticle(1079400.0, 0.00115) }, { 0.00747d, new GammaParticle(1105900.0, 0.00112) }, { 0.01577d, new GammaParticle(1182200.0, 0.00105) }, { 0.014110000000000001d, new GammaParticle(1246800.0, 0.00099) }, { 0.03403d, new GammaParticle(1392200.0, 0.00089) }, { 0.02075d, new GammaParticle(1677300.0, 0.00074) }, { 0.01079d, new GammaParticle(1758200.0, 0.00071) }, { 0.02158d, new GammaParticle(1780600.0, 0.0007) }, { 0.011619999999999998d, new GammaParticle(1876700.0, 0.00066) }, { 0.011619999999999998d, new GammaParticle(2249400.0, 0.00055) }, { 0.0013001471902005601d, new GammaParticle(2892.0, 0.42871) }, { 0.005424408850852569d, new GammaParticle(20073.0, 0.06177) }, { 0.010269611607066582d, new GammaParticle(20215.0, 0.06133) }, { 0.002788851662848069d, new GammaParticle(22806.0, 0.05436) }, { 0.003251801038880848d, new GammaParticle(22957.0, 0.05401) }, { 0.00046294937603277945d, new GammaParticle(23170.0, 0.05351) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    