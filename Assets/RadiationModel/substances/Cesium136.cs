using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium136";
        public override double halfLife { get; } = 1124064.0d;
        public override double atomicWeight { get; } = 135.90731d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium136() }, { 1.0d, new BetaParticle(-1, 1274090.0) }, { 0.047855999999999996d, new GammaParticle(66881.0, 0.01854) }, { 0.058823d, new GammaParticle(86360.0, 0.01436) }, { 0.0040877000000000005d, new GammaParticle(109681.0, 0.0113) }, { 0.076769d, new GammaParticle(153246.0, 0.00809) }, { 0.046859000000000005d, new GammaParticle(163920.0, 0.00756) }, { 0.0062810999999999995d, new GammaParticle(166576.0, 0.00744) }, { 0.136589d, new GammaParticle(176602.0, 0.00702) }, { 0.005383799999999999d, new GammaParticle(187285.0, 0.00662) }, { 0.0007976d, new GammaParticle(233500.0, 0.00531) }, { 0.12661899999999998d, new GammaParticle(273646.0, 0.00453) }, { 0.0002991d, new GammaParticle(302400.0, 0.0041) }, { 0.0001994d, new GammaParticle(315500.0, 0.00393) }, { 0.004985d, new GammaParticle(319911.0, 0.00388) }, { 0.46759300000000004d, new GammaParticle(340547.0, 0.00364) }, { 0.0007976d, new GammaParticle(490000.0, 0.00253) }, { 0.00997d, new GammaParticle(507188.0, 0.00244) }, { 0.0001994d, new GammaParticle(733000.0, 0.00169) }, { 0.997d, new GammaParticle(818514.0, 0.00151) }, { 0.7976000000000001d, new GammaParticle(1048073.0, 0.00118) }, { 0.200397d, new GammaParticle(1235362.0, 0.001) }, { 0.0004985d, new GammaParticle(1321580.0, 0.00094) }, { 0.000997d, new GammaParticle(1538090.0, 0.00081) }, { 0.00014955d, new GammaParticle(1551300.0, 0.0008) }, { 0.02114047614236723d, new GammaParticle(4966.0, 0.24967) }, { 0.037114957415493734d, new GammaParticle(31816.0, 0.03897) }, { 0.0683768559607475d, new GammaParticle(32193.0, 0.03851) }, { 0.02011253662372906d, new GammaParticle(36482.0, 0.03399) }, { 0.025180895852908784d, new GammaParticle(36827.0, 0.03367) }, { 0.005068359229179723d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    