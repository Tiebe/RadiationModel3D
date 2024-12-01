using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead203n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203n";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 202.97656d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead203()), new(9.609208000000001e-12d, new GammaParticle(5000.0, 0.24797)), new(0.000396256d, new GammaParticle(21800.0, 0.05687)), new(0.05646648d, new GammaParticle(153400.0, 0.00808)), new(0.01287832d, new GammaParticle(173900.0, 0.00713)), new(0.00891576d, new GammaParticle(217400.0, 0.0057)), new(0.014859599999999999d, new GammaParticle(231900.0, 0.00535)), new(0.04854136d, new GammaParticle(238500.0, 0.0052)), new(0.12779256d, new GammaParticle(239300.0, 0.00518)), new(0.8222311999999999d, new GammaParticle(258400.0, 0.0048)), new(0.0396256d, new GammaParticle(280200.0, 0.00442)), new(0.0099064d, new GammaParticle(453800.0, 0.00273)), new(0.20902504d, new GammaParticle(634500.0, 0.00195)), new(0.03665368d, new GammaParticle(678100.0, 0.00183)), new(0.05646648d, new GammaParticle(820200.0, 0.00151)), new(0.72613912d, new GammaParticle(825100.0, 0.0015)), new(0.99064d, new GammaParticle(838500.0, 0.00148)), new(0.0445788d, new GammaParticle(851900.0, 0.00146)), new(0.50621704d, new GammaParticle(873800.0, 0.00142)), new(0.15156792d, new GammaParticle(1027000.0, 0.00121)), new(0.4345098710236073d, new GammaParticle(12522.0, 0.09901)), new(0.12370122834199608d, new GammaParticle(72805.0, 0.01703)), new(0.20790122410419506d, new GammaParticle(74970.0, 0.01654)), new(0.07105766838132666d, new GammaParticle(84986.0, 0.01459)), new(0.0925170842324873d, new GammaParticle(86022.0, 0.01441)), new(0.02145941585116065d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    