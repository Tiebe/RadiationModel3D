using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium73n : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium73n";
        public override double halfLife { get; } = 0.499d;
        public override double atomicWeight { get; } = 72.92353d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium73()), new(0.00094d, new GammaParticle(13284.5, 0.09333)), new(0.1067d, new GammaParticle(53437.0, 0.0232)), new(0.02880829d, new GammaParticle(1221.0, 1.01543)), new(0.16850402117659516d, new GammaParticle(9856.0, 0.1258)), new(0.32725581894852435d, new GammaParticle(9887.0, 0.1254)), new(0.0731997650439144d, new GammaParticle(11026.0, 0.11245)), new(0.07481015987488053d, new GammaParticle(11038.0, 0.11232)), new(0.0016103948309661167d, new GammaParticle(11099.0, 0.11171)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    