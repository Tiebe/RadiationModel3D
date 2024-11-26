using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium98m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.91983d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium98() }, { 0.17d, new GammaParticle(63000.0, 0.01968) }, { 0.1d, new GammaParticle(240100.0, 0.00516) }, { 0.31d, new GammaParticle(511900.0, 0.00242) }, { 0.39d, new GammaParticle(583200.0, 0.00213) }, { 0.67d, new GammaParticle(620400.0, 0.002) }, { 0.56d, new GammaParticle(622600.0, 0.00199) }, { 0.55d, new GammaParticle(647000.0, 0.00192) }, { 0.59d, new GammaParticle(717700.0, 0.00173) }, { 0.53d, new GammaParticle(725400.0, 0.00171) }, { 0.16d, new GammaParticle(752600.0, 0.00165) }, { 0.4d, new GammaParticle(768400.0, 0.00161) }, { 0.44d, new GammaParticle(770000.0, 0.00161) }, { 0.28d, new GammaParticle(776000.0, 0.0016) }, { 0.72d, new GammaParticle(804300.0, 0.00154) }, { 0.68d, new GammaParticle(820400.0, 0.00151) }, { 0.37d, new GammaParticle(834600.0, 0.00149) }, { 0.4d, new GammaParticle(952100.0, 0.0013) }, { 0.08d, new GammaParticle(994200.0, 0.00125) }, { 0.13d, new GammaParticle(1221000.0, 0.00102) }, { 1.0d, new GammaParticle(1222700.0, 0.00101) }, { 0.21d, new GammaParticle(1258200.0, 0.00099) }, { 0.032240350085434d, new GammaParticle(2161.0, 0.57374) }, { 0.163184547116379d, new GammaParticle(15691.0, 0.07902) }, { 0.31231492271077327d, new GammaParticle(15775.0, 0.0786) }, { 0.07958184844053039d, new GammaParticle(17736.0, 0.06991) }, { 0.09120079831284782d, new GammaParticle(17824.0, 0.06956) }, { 0.011618949872317437d, new GammaParticle(17968.0, 0.069) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    