using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium140";
        public override double halfLife { get; } = 291168.0d;
        public override double atomicWeight { get; } = 139.90955d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium140() }, { 0.1127979468d, new GammaParticle(5637.0, 0.21995) }, { 0.21447282937570422d, new GammaParticle(35551.0, 0.03488) }, { 0.3916596591959536d, new GammaParticle(36027.0, 0.03441) }, { 0.11915136260218336d, new GammaParticle(40857.0, 0.03035) }, { 0.1496541114283423d, new GammaParticle(41266.0, 0.03005) }, { 0.03050274882615894d, new GammaParticle(41766.0, 0.02969) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    