using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143n : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143n";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 142.91763d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium143() }, { 0.26d, new GammaParticle(76500.0, 0.01621) }, { 0.52d, new GammaParticle(208000.0, 0.00596) }, { 0.67d, new GammaParticle(1573400.0, 0.00079) }, { 0.21d, new GammaParticle(1705500.0, 0.00073) }, { 0.12d, new GammaParticle(1831700.0, 0.00068) }, { 0.19469545576000002d, new GammaParticle(6354.0, 0.19513) }, { 0.27660233814934687d, new GammaParticle(39522.0, 0.03137) }, { 0.5006377161074151d, new GammaParticle(40117.0, 0.03091) }, { 0.1564983352489967d, new GammaParticle(45523.0, 0.02724) }, { 0.19687490574323785d, new GammaParticle(45998.0, 0.02695) }, { 0.04037657049424115d, new GammaParticle(46575.0, 0.02662) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    