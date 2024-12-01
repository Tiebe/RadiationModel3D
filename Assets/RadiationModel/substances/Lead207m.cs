using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead207m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead207m";
        public override double halfLife { get; } = 0.806d;
        public override double atomicWeight { get; } = 206.97765d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead207()), new(0.9790000000000001d, new GammaParticle(569698.0, 0.00218)), new(0.888d, new GammaParticle(1063656.0, 0.00117)), new(0.04011357408573d, new GammaParticle(12522.0, 0.09901)), new(0.027847893119110005d, new GammaParticle(72805.0, 0.01703)), new(0.046803181712789924d, new GammaParticle(74970.0, 0.01654)), new(0.015996658892549986d, new GammaParticle(84986.0, 0.01459)), new(0.020827649878100082d, new GammaParticle(86022.0, 0.01441)), new(0.004830990985550096d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    