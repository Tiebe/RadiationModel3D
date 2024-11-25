using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum166 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum166";
        public override double halfLife { get; } = 34.4d;
        public override double atomicWeight { get; } = 165.95051d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium166() }, { 1.0d, new BetaParticle(1, 4961500.0) }, { 0.541d, new GammaParticle(158640.0, 0.00782) }, { 0.24182700000000001d, new GammaParticle(311870.0, 0.00398) }, { 0.015688999999999998d, new GammaParticle(397600.0, 0.00312) }, { 0.0065461d, new GammaParticle(426700.0, 0.00291) }, { 0.010820000000000001d, new GammaParticle(536810.0, 0.00231) }, { 0.0050854d, new GammaParticle(544270.0, 0.00228) }, { 0.030296d, new GammaParticle(552400.0, 0.00224) }, { 0.030837d, new GammaParticle(594650.0, 0.00208) }, { 0.10224899999999999d, new GammaParticle(651260.0, 0.0019) }, { 0.023804d, new GammaParticle(692230.0, 0.00179) }, { 0.07195299999999999d, new GammaParticle(742800.0, 0.00167) }, { 0.01623d, new GammaParticle(748250.0, 0.00166) }, { 0.056264d, new GammaParticle(750000.0, 0.00165) }, { 0.109282d, new GammaParticle(810000.0, 0.00153) }, { 0.068707d, new GammaParticle(848410.0, 0.00146) }, { 0.018394d, new GammaParticle(851700.0, 0.00146) }, { 0.029214000000000004d, new GammaParticle(861970.0, 0.00144) }, { 0.049772d, new GammaParticle(864100.0, 0.00143) }, { 0.011361000000000001d, new GammaParticle(906350.0, 0.00137) }, { 0.025426999999999998d, new GammaParticle(977000.0, 0.00127) }, { 0.044903000000000005d, new GammaParticle(1054400.0, 0.00118) }, { 0.012443d, new GammaParticle(1060200.0, 0.00117) }, { 0.008656d, new GammaParticle(1080860.0, 0.00115) }, { 0.013525d, new GammaParticle(1132750.0, 0.00109) }, { 0.031919d, new GammaParticle(1173740.0, 0.00106) }, { 0.005410000000000001d, new GammaParticle(1218800.0, 0.00102) }, { 0.029214000000000004d, new GammaParticle(1246370.0, 0.00099) }, { 0.031377999999999996d, new GammaParticle(1288300.0, 0.00096) }, { 0.012443d, new GammaParticle(1444400.0, 0.00086) }, { 0.034083d, new GammaParticle(1447000.0, 0.00086) }, { 1.6680000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.1101527798966114d, new GammaParticle(9114.0, 0.13604) }, { 0.08746207445875542d, new GammaParticle(54608.0, 0.0227) }, { 0.15306628361700286d, new GammaParticle(55786.0, 0.02222) }, { 0.050497666336347044d, new GammaParticle(63333.0, 0.01958) }, { 0.06398054324815171d, new GammaParticle(64057.0, 0.01936) }, { 0.013482876911804663d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    