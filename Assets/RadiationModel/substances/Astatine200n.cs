using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200n";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 199.99072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.895d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine200() } } },
            { 0.105d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth196() }, { 1.0d, new AlphaParticle(7962002.09) }, { 0.000673d, new GammaParticle(102000.0, 0.01216) }, { 0.00134d, new GammaParticle(158300.0, 0.00783) }, { 0.0604506752325d, new GammaParticle(12904.0, 0.09608) }, { 0.011936800155594762d, new GammaParticle(74815.0, 0.01657) }, { 0.019971223281905242d, new GammaParticle(77108.0, 0.01608) }, { 0.006840923861026034d, new GammaParticle(87388.0, 0.01419) }, { 0.0089342465625d, new GammaParticle(88458.0, 0.01402) }, { 0.0020933227014739665d, new GammaParticle(89784.0, 0.01381) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    