using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium219";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 219.00925d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine215()), new(1.0d, new AlphaParticle(8471002.09)), new(6e-05d, new GammaParticle(153000.0, 0.0081)), new(0.001d, new GammaParticle(169900.0, 0.0073)), new(0.0001d, new GammaParticle(225000.0, 0.00551)), new(6e-05d, new GammaParticle(302600.0, 0.0041)), new(0.005600000000000001d, new GammaParticle(352000.0, 0.00352)), new(0.0005d, new GammaParticle(472200.0, 0.00263)), new(0.0019d, new GammaParticle(517000.0, 0.0024)), new(0.0008792751552d, new GammaParticle(13686.0, 0.09059)), new(0.0005328508144475385d, new GammaParticle(78947.0, 0.0157)), new(0.0008832269425618073d, new GammaParticle(81517.0, 0.01521)), new(0.00030582972090544046d, new GammaParticle(92333.0, 0.01343)), new(0.0004021660829906542d, new GammaParticle(93473.0, 0.01326)), new(9.633636208521375e-05d, new GammaParticle(94897.0, 0.01307)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    