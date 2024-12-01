using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine200n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200n";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 199.99072d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.895d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine200()) } },
            { 0.105d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth196()), new(1.0d, new AlphaParticle(7962002.09)), new(0.000673d, new GammaParticle(102000.0, 0.01216)), new(0.00134d, new GammaParticle(158300.0, 0.00783)), new(0.0604506752325d, new GammaParticle(12904.0, 0.09608)), new(0.011936800155594762d, new GammaParticle(74815.0, 0.01657)), new(0.019971223281905242d, new GammaParticle(77108.0, 0.01608)), new(0.006840923861026034d, new GammaParticle(87388.0, 0.01419)), new(0.0089342465625d, new GammaParticle(88458.0, 0.01402)), new(0.0020933227014739665d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    