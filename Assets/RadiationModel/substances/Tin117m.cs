using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin117m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin117m";
        public override double halfLife { get; } = 1209600.0d;
        public override double atomicWeight { get; } = 116.90329d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin117() }, { 0.02113344d, new GammaParticle(156020.0, 0.00795) }, { 0.8640000000000001d, new GammaParticle(158560.0, 0.00782) }, { 4.2336000000000004e-06d, new GammaParticle(314300.0, 0.00394) }, { 0.07402726701111491d, new GammaParticle(3753.0, 0.33036) }, { 0.1890330264843858d, new GammaParticle(25044.0, 0.04951) }, { 0.3537956700063368d, new GammaParticle(25271.0, 0.04906) }, { 0.10004010897732116d, new GammaParticle(28579.0, 0.04338) }, { 0.11974801044585343d, new GammaParticle(28810.0, 0.04304) }, { 0.01970790146853227d, new GammaParticle(29107.0, 0.0426) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    