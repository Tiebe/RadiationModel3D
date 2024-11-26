using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium117";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 116.92604d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium117() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.10800000000000001d, new GammaParticle(34600.0, 0.03583) }, { 0.11d, new GammaParticle(97100.0, 0.01277) }, { 0.33d, new GammaParticle(131800.0, 0.00941) }, { 0.053145632799999995d, new GammaParticle(3053.0, 0.40611) }, { 0.21054118890024145d, new GammaParticle(21020.0, 0.05898) }, { 0.3977728866431919d, new GammaParticle(21177.0, 0.05855) }, { 0.10913258500561254d, new GammaParticle(23904.0, 0.05187) }, { 0.12768512445656666d, new GammaParticle(24070.0, 0.05151) }, { 0.01855253945095413d, new GammaParticle(24297.0, 0.05103) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    