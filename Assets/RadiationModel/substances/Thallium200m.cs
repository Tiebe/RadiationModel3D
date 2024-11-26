using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium200m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium200m";
        public override double halfLife { get; } = 0.034d;
        public override double atomicWeight { get; } = 199.97177d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium200() }, { 0.26530000000000004d, new GammaParticle(212700.0, 0.00583) }, { 0.06480000000000001d, new GammaParticle(217200.0, 0.00571) }, { 0.0962d, new GammaParticle(323700.0, 0.00383) }, { 0.8533d, new GammaParticle(540900.0, 0.00229) }, { 0.235315352350996d, new GammaParticle(12148.0, 0.10206) }, { 0.05436361657089992d, new GammaParticle(70832.0, 0.0175) }, { 0.09176842770239689d, new GammaParticle(72874.0, 0.01701) }, { 0.03120938802135946d, new GammaParticle(82629.0, 0.015) }, { 0.040478576263703214d, new GammaParticle(83631.0, 0.01483) }, { 0.00926918824234376d, new GammaParticle(84866.0, 0.01461) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    