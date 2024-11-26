using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium245";
        public override double halfLife { get; } = 428544.0d;
        public override double atomicWeight { get; } = 245.06636d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9987999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium245()), new(0.0039000000000000003d, new GammaParticle(103100.0, 0.01203)), new(0.00167d, new GammaParticle(198000.0, 0.00626)), new(0.307d, new GammaParticle(252850.0, 0.0049)), new(0.000127d, new GammaParticle(272200.0, 0.00455)), new(0.0008d, new GammaParticle(350500.0, 0.00354)), new(0.0038d, new GammaParticle(365800.0, 0.00339)), new(0.0253d, new GammaParticle(380800.0, 0.00326)), new(0.006d, new GammaParticle(385000.0, 0.00322)), new(0.00029d, new GammaParticle(407800.0, 0.00304)), new(0.0022500000000000003d, new GammaParticle(408700.0, 0.00303)), new(0.000147d, new GammaParticle(488200.0, 0.00254)), new(0.7274074129739949d, new GammaParticle(18579.0, 0.06673)), new(0.35128197296287894d, new GammaParticle(104606.0, 0.01185)), new(0.5499952606276483d, new GammaParticle(109286.0, 0.01134)), new(0.2059871783871841d, new GammaParticle(123280.0, 0.01006)), new(0.2784946651794729d, new GammaParticle(124855.0, 0.00993)), new(0.0725074867922888d, new GammaParticle(126917.0, 0.00977)) } },
            { 0.0012d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium241()), new(1.0d, new AlphaParticle(7476502.09)), new(8.4e-05d, new GammaParticle(165500.0, 0.00749)), new(1.1999999999999999e-05d, new GammaParticle(195000.0, 0.00636)), new(0.0004d, new GammaParticle(207400.0, 0.00598)), new(1.4e-06d, new GammaParticle(265922.0, 0.00466)), new(1.5e-05d, new GammaParticle(430634.0, 0.00288)), new(0.00026d, new GammaParticle(471800.0, 0.00263)), new(5.07314188248e-05d, new GammaParticle(18078.0, 0.06858)), new(2.712462028207909e-05d, new GammaParticle(102031.0, 0.01215)), new(4.2702487849620746e-05d, new GammaParticle(106468.0, 0.01165)), new(1.5827477843185298e-05d, new GammaParticle(120157.0, 0.01032)), new(2.136709508830015e-05d, new GammaParticle(121688.0, 0.01019)), new(5.5396172451148535e-06d, new GammaParticle(123677.0, 0.01002)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    