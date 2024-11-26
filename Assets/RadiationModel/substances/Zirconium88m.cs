using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium88m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.91332d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium88() }, { 0.2571d, new GammaParticle(76990.0, 0.0161) }, { 0.332d, new GammaParticle(271800.0, 0.00456) }, { 0.33299999999999996d, new GammaParticle(399410.0, 0.0031) }, { 0.665d, new GammaParticle(671200.0, 0.00185) }, { 0.9995d, new GammaParticle(1057010.0, 0.00117) }, { 0.9995d, new GammaParticle(1082530.0, 0.00115) }, { 0.024065178689595998d, new GammaParticle(2161.0, 0.57374) }, { 0.12611747955720137d, new GammaParticle(15691.0, 0.07902) }, { 0.24137316661665334d, new GammaParticle(15775.0, 0.0786) }, { 0.061504979001872025d, new GammaParticle(17736.0, 0.06991) }, { 0.07048470593614534d, new GammaParticle(17824.0, 0.06956) }, { 0.008979726934273317d, new GammaParticle(17968.0, 0.069) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    