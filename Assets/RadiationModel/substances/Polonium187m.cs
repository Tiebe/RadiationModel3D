using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium187m";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 187.00304d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead183()), new(1.0d, new AlphaParticle(9007002.09)), new(0.6729999999999999d, new GammaParticle(286000.0, 0.00434)), new(0.099387823d, new GammaParticle(12522.0, 0.09901)), new(0.0749934411925461d, new GammaParticle(72805.0, 0.01703)), new(0.12603939696226235d, new GammaParticle(74970.0, 0.01654)), new(0.04307846531888753d, new GammaParticle(84986.0, 0.01459)), new(0.05608816184519157d, new GammaParticle(86022.0, 0.01441)), new(0.013009696526304033d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    