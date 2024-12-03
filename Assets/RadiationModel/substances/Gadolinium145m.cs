using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium145m";
        public override double halfLife { get; } = 85.0d;
        public override double atomicWeight { get; } = 144.92251d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.943d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium145()), new(0.045d, new GammaParticle(27300.0, 0.04542)), new(0.82d, new GammaParticle(721400.0, 0.00172)), new(0.14125719520000002d, new GammaParticle(6858.0, 0.18079)), new(0.024984038291114254d, new GammaParticle(42308.0, 0.02931)), new(0.044943404013517284d, new GammaParticle(42996.0, 0.02884)), new(0.014206953044630604d, new GammaParticle(48802.0, 0.02541)), new(0.01794338169536845d, new GammaParticle(49326.0, 0.02514)), new(0.0037364286507378486d, new GammaParticle(49957.0, 0.02482)) } },
            { 0.057d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium145()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.043d, new GammaParticle(329500.0, 0.00376)), new(0.039d, new GammaParticle(386600.0, 0.00321)), new(0.011000000000000001d, new GammaParticle(716000.0, 0.00173)), new(0.005d, new GammaParticle(511000.0, 0.00243)), new(0.00144859532664d, new GammaParticle(6603.0, 0.18777)), new(0.0022531050053488273d, new GammaParticle(40901.0, 0.03031)), new(0.004065508851224879d, new GammaParticle(41541.0, 0.02985)), new(0.001280800106062238d, new GammaParticle(47146.0, 0.0263)), new(0.001611246533426295d, new GammaParticle(47645.0, 0.02602)), new(0.0003304464273640574d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    