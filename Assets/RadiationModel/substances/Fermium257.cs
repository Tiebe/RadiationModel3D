using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium257";
        public override double halfLife { get; } = 8683200.0d;
        public override double atomicWeight { get; } = 257.09511d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9979d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium253() }, { 1.0d, new AlphaParticle(7885002.09) }, { 0.013500000000000002d, new GammaParticle(61600.0, 0.02013) }, { 0.0018599999999999999d, new GammaParticle(75000.0, 0.01653) }, { 0.00079d, new GammaParticle(80200.0, 0.01546) }, { 0.00016d, new GammaParticle(96000.0, 0.01292) }, { 0.0058d, new GammaParticle(104400.0, 0.01188) }, { 0.0005600000000000001d, new GammaParticle(136700.0, 0.00907) }, { 0.081d, new GammaParticle(179400.0, 0.00691) }, { 0.102d, new GammaParticle(241000.0, 0.00514) }, { 0.59d, new GammaParticle(19579.0, 0.06333) }, { 0.13493877112513167d, new GammaParticle(109867.0, 0.01128) }, { 0.20881889682007376d, new GammaParticle(115063.0, 0.01078) }, { 0.07960170186931748d, new GammaParticle(129671.0, 0.00956) }, { 0.1079399077347945d, new GammaParticle(131332.0, 0.00944) }, { 0.028338205865477018d, new GammaParticle(133529.0, 0.00929) } } },
            { 0.0021d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    